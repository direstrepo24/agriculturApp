import { Component, Injector } from '@angular/core';
import { ComprasGenerated } from './compras-generated.component';

@Component({
  selector: 'compras',
  templateUrl: './compras.component.html'
})
export class ComprasComponent extends ComprasGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
