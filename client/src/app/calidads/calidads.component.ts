import { Component, Injector } from '@angular/core';
import { CalidadsGenerated } from './calidads-generated.component';

@Component({
  selector: 'calidads',
  templateUrl: './calidads.component.html'
})
export class CalidadsComponent extends CalidadsGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
