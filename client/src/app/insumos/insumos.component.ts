import { Component, Injector } from '@angular/core';
import { InsumosGenerated } from './insumos-generated.component';

@Component({
  selector: 'insumos',
  templateUrl: './insumos.component.html'
})
export class InsumosComponent extends InsumosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
