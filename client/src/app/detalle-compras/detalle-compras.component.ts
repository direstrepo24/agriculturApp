import { Component, Injector } from '@angular/core';
import { DetalleComprasGenerated } from './detalle-compras-generated.component';

@Component({
  selector: 'detalle-compras',
  templateUrl: './detalle-compras.component.html'
})
export class DetalleComprasComponent extends DetalleComprasGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
