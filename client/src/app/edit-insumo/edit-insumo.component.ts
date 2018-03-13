import { Component, Injector } from '@angular/core';
import { EditInsumoGenerated } from './edit-insumo-generated.component';

@Component({
  selector: 'edit-insumo',
  templateUrl: './edit-insumo.component.html'
})
export class EditInsumoComponent extends EditInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
