import { Component, Injector } from '@angular/core';
import { AddTipoInsumoGenerated } from './add-tipo-insumo-generated.component';

@Component({
  selector: 'add-tipo-insumo',
  templateUrl: './add-tipo-insumo.component.html'
})
export class AddTipoInsumoComponent extends AddTipoInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
