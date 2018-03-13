import { Component, Injector } from '@angular/core';
import { LaboratoriosGenerated } from './laboratorios-generated.component';

@Component({
  selector: 'laboratorios',
  templateUrl: './laboratorios.component.html'
})
export class LaboratoriosComponent extends LaboratoriosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
