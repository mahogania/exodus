import { PropertyCreateNestedManyWithoutPropertyTypesInput } from "./PropertyCreateNestedManyWithoutPropertyTypesInput";
import { ObjectTypeCreateNestedManyWithoutPropertyTypesInput } from "./ObjectTypeCreateNestedManyWithoutPropertyTypesInput";
import { InputJsonValue } from "../../types";

export type PropertyTypeCreateInput = {
  dynamicPropertyInstances?: PropertyCreateNestedManyWithoutPropertyTypesInput;
  objectTypes?: ObjectTypeCreateNestedManyWithoutPropertyTypesInput;
  schema: InputJsonValue;
};
