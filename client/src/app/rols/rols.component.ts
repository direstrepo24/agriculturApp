import { Component, Injector } from '@angular/core';
import { RolsGenerated } from './rols-generated.component';

@Component({
  selector: 'rols',
  templateUrl: './rols.component.html'
})
export class RolsComponent extends RolsGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
