import { Component, Injector } from '@angular/core';
import { ProduccionsGenerated } from './produccions-generated.component';

@Component({
  selector: 'produccions',
  templateUrl: './produccions.component.html'
})
export class ProduccionsComponent extends ProduccionsGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
