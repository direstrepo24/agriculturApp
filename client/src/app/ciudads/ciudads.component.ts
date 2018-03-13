import { Component, Injector } from '@angular/core';
import { CiudadsGenerated } from './ciudads-generated.component';

@Component({
  selector: 'ciudads',
  templateUrl: './ciudads.component.html'
})
export class CiudadsComponent extends CiudadsGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
