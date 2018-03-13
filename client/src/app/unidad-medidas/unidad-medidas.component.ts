import { Component, Injector } from '@angular/core';
import { UnidadMedidasGenerated } from './unidad-medidas-generated.component';

@Component({
  selector: 'unidad-medidas',
  templateUrl: './unidad-medidas.component.html'
})
export class UnidadMedidasComponent extends UnidadMedidasGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
