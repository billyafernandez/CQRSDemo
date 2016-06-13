import { bootstrap } from '@angular/platform-browser-dynamic';
import { enableProdMode } from '@angular/core';
import { CQRSng2AppComponent, environment } from './app/';
import { HTTP_PROVIDERS } from '@angular/http';

if (environment.production) {
  enableProdMode();
}

bootstrap(CQRSng2AppComponent, [HTTP_PROVIDERS]);

