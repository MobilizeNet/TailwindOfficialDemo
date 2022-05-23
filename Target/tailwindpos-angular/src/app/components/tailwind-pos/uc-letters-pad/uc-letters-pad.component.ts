import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { UserControlComponent, WebComponentsService
} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tailwind-pos-uc-letters-pad",
   styleUrls : ["./uc-letters-pad.component.css"],
   templateUrl : "./uc-letters-pad.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TailwindPOSucLettersPad"])
export class ucLettersPadComponent extends UserControlComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2
   ,elem : ElementRef,webComponents : WebComponentsService) {
      super(wmservice,changeDetector,render2,elem,webComponents);
   }
}