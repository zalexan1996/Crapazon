import { StaticProvider } from '@angular/core';
import { AppModule } from './app/app.module';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { CUNT_BASE_URL } from './shared/services/api.service';

platformBrowserDynamic([{ provide: CUNT_BASE_URL, useValue: 'https://localhost:7139', deps: [] }])
 .bootstrapModule(AppModule)
 .catch(err => console.error(err));
