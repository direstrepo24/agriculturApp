import { Component, Injector } from '@angular/core';
import { AddUnidadProductivaGenerated } from './add-unidad-productiva-generated.component';

@Component({
  selector: 'add-unidad-productiva',
  templateUrl: './add-unidad-productiva.component.html'
})
export class AddUnidadProductivaComponent extends AddUnidadProductivaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
