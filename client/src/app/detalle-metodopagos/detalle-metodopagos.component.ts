import { Component, Injector } from '@angular/core';
import { DetalleMetodopagosGenerated } from './detalle-metodopagos-generated.component';

@Component({
  selector: 'detalle-metodopagos',
  templateUrl: './detalle-metodopagos.component.html'
})
export class DetalleMetodopagosComponent extends DetalleMetodopagosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
