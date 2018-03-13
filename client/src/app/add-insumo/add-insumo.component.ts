import { Component, Injector } from '@angular/core';
import { AddInsumoGenerated } from './add-insumo-generated.component';

@Component({
  selector: 'add-insumo',
  templateUrl: './add-insumo.component.html'
})
export class AddInsumoComponent extends AddInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
