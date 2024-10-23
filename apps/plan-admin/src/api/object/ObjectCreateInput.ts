import { PropertyCreateNestedManyWithoutObjectsInput } from "./PropertyCreateNestedManyWithoutObjectsInput";
import { ActionCreateNestedManyWithoutObjectsInput } from "./ActionCreateNestedManyWithoutObjectsInput";
import { AssociationCreateNestedManyWithoutObjectsInput } from "./AssociationCreateNestedManyWithoutObjectsInput";

export type ObjectCreateInput = {
  Properties?: PropertyCreateNestedManyWithoutObjectsInput;
  actions?: ActionCreateNestedManyWithoutObjectsInput;
  associations?: AssociationCreateNestedManyWithoutObjectsInput;
};
