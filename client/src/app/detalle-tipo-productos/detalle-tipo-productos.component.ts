import { Component, Injector } from '@angular/core';
import { DetalleTipoProductosGenerated } from './detalle-tipo-productos-generated.component';

@Component({
  selector: 'detalle-tipo-productos',
  templateUrl: './detalle-tipo-productos.component.html'
})
export class DetalleTipoProductosComponent extends DetalleTipoProductosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
