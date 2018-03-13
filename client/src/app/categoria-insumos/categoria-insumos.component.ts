import { Component, Injector } from '@angular/core';
import { CategoriaInsumosGenerated } from './categoria-insumos-generated.component';

@Component({
  selector: 'categoria-insumos',
  templateUrl: './categoria-insumos.component.html'
})
export class CategoriaInsumosComponent extends CategoriaInsumosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
