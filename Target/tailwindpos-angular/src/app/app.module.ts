import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA, NgZone, ChangeDetectorRef} from '@angular/core';
import { AppComponent } from './app.component';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';
import { TailwindPOSModule } from './tailwind-pos.module';
@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
    TailwindPOSModule,
  ],
  providers: [WebMapService  ],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }

