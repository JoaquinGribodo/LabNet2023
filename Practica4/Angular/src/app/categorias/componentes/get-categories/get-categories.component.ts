import { Component, Input, OnInit } from '@angular/core';
import { Categoria } from '../../models/categories';
import { ApiCallService } from '../../services/api-call.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-get-categories',
  templateUrl: './get-categories.component.html',
  styleUrls: ['./get-categories.component.css']
})
export class GetCategoriesComponent implements OnInit {

  constructor(private categoriasService: ApiCallService) { }
  public listarCategorias: Array<Categoria>;

  ngOnInit(): void {
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

  eliminarCategoria(id: number) : void{
    this.categoriasService.eliminarCategoria(id).subscribe({
      next: res => {
        this.listarCategorias = this.listarCategorias.filter(c => c.Id !== id);
      },
      error: err => Swal.fire("Error: no se pudo eliminar esa categoría.")
    });
  }
}
