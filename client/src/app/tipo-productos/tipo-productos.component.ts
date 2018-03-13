import { Component, Injector } from '@angular/core';
import { TipoProductosGenerated } from './tipo-productos-generated.component';

@Component({
  selector: 'tipo-productos',
  templateUrl: './tipo-productos.component.html'
})
export class TipoProductosComponent extends TipoProductosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
