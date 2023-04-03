import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GetCategoriesComponent } from './categorias/componentes/get-categories/get-categories.component';
import { PostCategoriesComponent } from './categorias/componentes/post-categories/post-categories.component';
import { UpdateCategoriesComponent } from './categorias/componentes/update-categories/update-categories.component';


const routes: Routes = [
  {
    path: '', component: GetCategoriesComponent
  },
  {
    path: 'app-post-categories', component: PostCategoriesComponent
  },
  {
    path: 'app-update-categories/:Id', component: UpdateCategoriesComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
