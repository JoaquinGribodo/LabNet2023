import { Component, OnInit, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiCallService } from '../../services/api-call.service';
import { Categoria } from '../../models/categories';
import { ActivatedRoute, Params } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-update-categories',
  templateUrl: './update-categories.component.html',
  styleUrls: ['./update-categories.component.css']
})
export class UpdateCategoriesComponent implements OnInit {

  id: number;

  public form: FormGroup = this.fb.group({
    name: ['', [Validators.required, Validators.maxLength(15), Validators.minLength(2)]],
    description: ['', [Validators.required, Validators.maxLength(80), Validators.minLength(10)]]
  })
  
  public listarCategorias: Array<Categoria>;

  constructor(private fb: FormBuilder, private categoriasService: ApiCallService, private rutaActiva: ActivatedRoute) 
  {
  }

  ngOnInit(): void {
    this.rutaActiva.params.subscribe(params => {
      this.id = params['Id'];
    });
    this.mostrarCategorias();
  }

  mostrarCategorias(){
    this.categoriasService.listarCategorias().subscribe({
      next: res => {
      this.listarCategorias = res
      },
      error: err => Swal.fire("Error: no se pudo cargar las categorías.")
    });
  }
   
  editarCategoria(){
      
      var categoria = this.listarCategorias.find(c => c.Id == this.id);
      categoria.Nombre = this.form.get('name').value;
      categoria.Descripcion = this.form.get('description').value;

      this.categoriasService.actualizarCategoria(categoria).subscribe({
        next: res => {
          this.form.reset();
          this.categoriasService.listarCategorias();
        },
        error: err => Swal.fire("Error: no se pudo modificar la categoría.")
      })

      this.listarCategorias.forEach(element => {
        console.log(element);
      });
  }
}
