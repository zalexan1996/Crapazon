import { NgModule } from "@angular/core";
import { HomeComponent } from "./home/home.component";
import { HomeRoutingModule } from "./home-routing.module";
import { HomeLayoutComponent } from "./home-layout/home-layout.component";
import { HttpClientModule } from "@angular/common/http";

@NgModule({
  declarations: [
    HomeComponent,
    HomeLayoutComponent
  ],
  imports: [
    HomeRoutingModule,
    HttpClientModule
  ]
})
export class HomeModule {

}
