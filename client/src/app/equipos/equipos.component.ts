import { Component, Injector } from '@angular/core';
import { EquiposGenerated } from './equipos-generated.component';

@Component({
  selector: 'equipos',
  templateUrl: './equipos.component.html'
})
export class EquiposComponent extends EquiposGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
