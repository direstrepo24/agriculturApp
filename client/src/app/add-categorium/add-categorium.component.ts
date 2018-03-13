import { Component, Injector } from '@angular/core';
import { AddCategoriumGenerated } from './add-categorium-generated.component';

@Component({
  selector: 'add-categorium',
  templateUrl: './add-categorium.component.html'
})
export class AddCategoriumComponent extends AddCategoriumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
