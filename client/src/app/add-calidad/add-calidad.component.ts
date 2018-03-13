import { Component, Injector } from '@angular/core';
import { AddCalidadGenerated } from './add-calidad-generated.component';

@Component({
  selector: 'add-calidad',
  templateUrl: './add-calidad.component.html'
})
export class AddCalidadComponent extends AddCalidadGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
