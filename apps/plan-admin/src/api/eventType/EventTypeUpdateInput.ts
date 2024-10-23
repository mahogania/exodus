import { EventUpdateManyWithoutEventTypesInput } from "./EventUpdateManyWithoutEventTypesInput";
import { ObjectTypeUpdateManyWithoutEventTypesInput } from "./ObjectTypeUpdateManyWithoutEventTypesInput";
import { InputJsonValue } from "../../types";

export type EventTypeUpdateInput = {
  events?: EventUpdateManyWithoutEventTypesInput;
  objectTypes?: ObjectTypeUpdateManyWithoutEventTypesInput;
  schema?: InputJsonValue;
};
