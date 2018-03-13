import { Component, Injector } from '@angular/core';
import { EditCategoriumGenerated } from './edit-categorium-generated.component';

@Component({
  selector: 'edit-categorium',
  templateUrl: './edit-categorium.component.html'
})
export class EditCategoriumComponent extends EditCategoriumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
