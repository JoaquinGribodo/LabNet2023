import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiCallService } from '../../services/api-call.service';
import { Categoria } from '../../models/categories';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-post-categories',
  templateUrl: './post-categories.component.html',
  styleUrls: ['./post-categories.component.css']
})
export class PostCategoriesComponent implements OnInit {

  public form: FormGroup = this.fb.group({
    name: ['', [Validators.required, Validators.maxLength(15), Validators.minLength(2)]],
    description: ['', [Validators.required, Validators.maxLength(80), Validators.minLength(10)]]
  })
  
  constructor(private fb: FormBuilder, private categoriasService: ApiCallService) { }

  ngOnInit(): void {
  }

  guardarNuevaCategoria(){
      var categoria = new Categoria();
      categoria.Nombre = this.form.get('name').value;
      categoria.Descripcion = this.form.get('description').value;

      this.categoriasService.crearCategoria(categoria).subscribe({
        next: res => {
          this.form.reset();
          this.categoriasService.listarCategorias();
        },
        error: err => Swal.fire("Error: no se pudo agregar la categoría.")
      });
  };
}
