import { NgModule } from "@angular/core";
import { AppRootComponent } from "./app-root/app-root.component";
import { AppRoutingModule } from "./app-routing.module";
import { CommonModule } from "@angular/common";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";

@NgModule({
  declarations: [
    AppRootComponent
  ],
  bootstrap: [
    AppRootComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ]
})
export class AppModule {

}
