import { Component, Injector } from '@angular/core';
import { AddDetalleCompraGenerated } from './add-detalle-compra-generated.component';

@Component({
  selector: 'add-detalle-compra',
  templateUrl: './add-detalle-compra.component.html'
})
export class AddDetalleCompraComponent extends AddDetalleCompraGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
