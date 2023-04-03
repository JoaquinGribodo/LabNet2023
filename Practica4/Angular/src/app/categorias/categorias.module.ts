import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { GetCategoriesComponent } from './componentes/get-categories/get-categories.component';
import { PostCategoriesComponent } from './componentes/post-categories/post-categories.component';
import { UpdateCategoriesComponent } from './componentes/update-categories/update-categories.component';
import { NavbarComponent } from './componentes/navbar/navbar.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    GetCategoriesComponent,
    PostCategoriesComponent,
    UpdateCategoriesComponent,
    NavbarComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule
  ]
})
export class CategoriasModule { }
