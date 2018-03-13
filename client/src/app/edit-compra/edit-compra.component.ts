import { Component, Injector } from '@angular/core';
import { EditCompraGenerated } from './edit-compra-generated.component';

@Component({
  selector: 'edit-compra',
  templateUrl: './edit-compra.component.html'
})
export class EditCompraComponent extends EditCompraGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
