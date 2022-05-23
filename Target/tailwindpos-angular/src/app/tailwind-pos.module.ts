
import { NgModule, CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BaseComponentsModule } from '@mobilize/base-components';
import { WebMapKendoModule } from '@mobilize/winforms-components';
import { WebMapService, WebMapModule } from '@mobilize/angularclient';

import * as TailwindPOS from './components/tailwind-pos';

@NgModule({
  imports: [
    CommonModule,
    BaseComponentsModule,
    WebMapKendoModule,
    WebMapModule,
  ],
  exports: [
    TailwindPOS.frmCashCountComponent,
    TailwindPOS.frmCustAddComponent,
    TailwindPOS.frmGiftCardCodeComponent,
    TailwindPOS.frmPauseComponent,
    TailwindPOS.frmPaymentComponent,
    TailwindPOS.frmSalesComponent,
    TailwindPOS.frmSearchCustComponent,
    TailwindPOS.ucLettersPadComponent,
    TailwindPOS.ucNumbersPadComponent,
  ],
  declarations: [
    TailwindPOS.frmCashCountComponent,
    TailwindPOS.frmCustAddComponent,
    TailwindPOS.frmGiftCardCodeComponent,
    TailwindPOS.frmPauseComponent,
    TailwindPOS.frmPaymentComponent,
    TailwindPOS.frmSalesComponent,
    TailwindPOS.frmSearchCustComponent,
    TailwindPOS.ucLettersPadComponent,
    TailwindPOS.ucNumbersPadComponent,
  ],
  bootstrap: [
    TailwindPOS.frmCashCountComponent,
    TailwindPOS.frmCustAddComponent,
    TailwindPOS.frmGiftCardCodeComponent,
    TailwindPOS.frmPauseComponent,
    TailwindPOS.frmPaymentComponent,
    TailwindPOS.frmSalesComponent,
    TailwindPOS.frmSearchCustComponent,
    TailwindPOS.ucLettersPadComponent,
    TailwindPOS.ucNumbersPadComponent,
  ],
   providers: [WebMapService],
   schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class TailwindPOSModule { }

