import { Component, Injector } from '@angular/core';
import { AddCompraGenerated } from './add-compra-generated.component';

@Component({
  selector: 'add-compra',
  templateUrl: './add-compra.component.html'
})
export class AddCompraComponent extends AddCompraGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
