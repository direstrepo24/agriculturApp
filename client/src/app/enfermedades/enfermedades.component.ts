import { Component, Injector } from '@angular/core';
import { EnfermedadesGenerated } from './enfermedades-generated.component';

@Component({
  selector: 'enfermedades',
  templateUrl: './enfermedades.component.html'
})
export class EnfermedadesComponent extends EnfermedadesGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
