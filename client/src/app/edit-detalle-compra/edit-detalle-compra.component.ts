import { Component, Injector } from '@angular/core';
import { EditDetalleCompraGenerated } from './edit-detalle-compra-generated.component';

@Component({
  selector: 'edit-detalle-compra',
  templateUrl: './edit-detalle-compra.component.html'
})
export class EditDetalleCompraComponent extends EditDetalleCompraGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
