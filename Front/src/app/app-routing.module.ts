import { RouterModule, Routes } from '@angular/router';
import { AppRootComponent } from './app-root/app-root.component';
import { NgModule } from '@angular/core';
import { HomeComponent } from '../home/home/home.component';

const AppRoutes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'home',
        loadChildren: () => import('../home/home.module').then(m => m.HomeModule)
      },
      {
        path: '',
        component: HomeComponent
      },
    ]
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(AppRoutes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {

}
