import { Component, Injector } from '@angular/core';
import { TipoInsumosGenerated } from './tipo-insumos-generated.component';

@Component({
  selector: 'tipo-insumos',
  templateUrl: './tipo-insumos.component.html'
})
export class TipoInsumosComponent extends TipoInsumosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
