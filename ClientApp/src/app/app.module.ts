import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { CarouselComponent } from './carousel/carousel.component';
import { CategoryComponent } from './category/category.component';
import { FooterComponent } from './footer/footer.component';
import { WebDevlopmentComponent } from './category/web-devlopment/web-devlopment.component';
import { BusinessComponent } from './category/business/business.component';
import { GamingComponent } from './category/gaming/gaming.component';
import { CardsComponent } from './cards/cards.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';


@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    CarouselComponent,
    CategoryComponent,
    FooterComponent,
    WebDevlopmentComponent,
    BusinessComponent,
    GamingComponent,
    CardsComponent,
    LoginComponent,
    HomeComponent,
    RegisterComponent,

    // LoginService
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
