import { Component, Injector } from '@angular/core';
import { EditUnidadProductivaGenerated } from './edit-unidad-productiva-generated.component';

@Component({
  selector: 'edit-unidad-productiva',
  templateUrl: './edit-unidad-productiva.component.html'
})
export class EditUnidadProductivaComponent extends EditUnidadProductivaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
