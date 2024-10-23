import { PropertyUpdateManyWithoutObjectsInput } from "./PropertyUpdateManyWithoutObjectsInput";
import { ActionUpdateManyWithoutObjectsInput } from "./ActionUpdateManyWithoutObjectsInput";
import { AssociationUpdateManyWithoutObjectsInput } from "./AssociationUpdateManyWithoutObjectsInput";

export type ObjectUpdateInput = {
  Properties?: PropertyUpdateManyWithoutObjectsInput;
  actions?: ActionUpdateManyWithoutObjectsInput;
  associations?: AssociationUpdateManyWithoutObjectsInput;
};
