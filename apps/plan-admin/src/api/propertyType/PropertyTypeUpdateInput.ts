import { PropertyUpdateManyWithoutPropertyTypesInput } from "./PropertyUpdateManyWithoutPropertyTypesInput";
import { ObjectTypeUpdateManyWithoutPropertyTypesInput } from "./ObjectTypeUpdateManyWithoutPropertyTypesInput";
import { InputJsonValue } from "../../types";

export type PropertyTypeUpdateInput = {
  dynamicPropertyInstances?: PropertyUpdateManyWithoutPropertyTypesInput;
  objectTypes?: ObjectTypeUpdateManyWithoutPropertyTypesInput;
  schema?: InputJsonValue;
};
