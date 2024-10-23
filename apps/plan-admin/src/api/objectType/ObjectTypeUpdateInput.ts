import { PropertyTypeWhereUniqueInput } from "../propertyType/PropertyTypeWhereUniqueInput";
import { EventTypeWhereUniqueInput } from "../eventType/EventTypeWhereUniqueInput";

export type ObjectTypeUpdateInput = {
  PropertyTypes?: PropertyTypeWhereUniqueInput;
  eventTypes?: EventTypeWhereUniqueInput;
};
