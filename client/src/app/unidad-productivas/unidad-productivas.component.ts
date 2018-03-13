import { Component, Injector } from '@angular/core';
import { UnidadProductivasGenerated } from './unidad-productivas-generated.component';

@Component({
  selector: 'unidad-productivas',
  templateUrl: './unidad-productivas.component.html'
})
export class UnidadProductivasComponent extends UnidadProductivasGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
