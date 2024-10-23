import { EventCreateNestedManyWithoutEventTypesInput } from "./EventCreateNestedManyWithoutEventTypesInput";
import { ObjectTypeCreateNestedManyWithoutEventTypesInput } from "./ObjectTypeCreateNestedManyWithoutEventTypesInput";
import { InputJsonValue } from "../../types";

export type EventTypeCreateInput = {
  events?: EventCreateNestedManyWithoutEventTypesInput;
  objectTypes?: ObjectTypeCreateNestedManyWithoutEventTypesInput;
  schema?: InputJsonValue;
};
