import { PropertyTypeWhereUniqueInput } from "../propertyType/PropertyTypeWhereUniqueInput";
import { EventTypeWhereUniqueInput } from "../eventType/EventTypeWhereUniqueInput";

export type ObjectTypeCreateInput = {
  PropertyTypes: PropertyTypeWhereUniqueInput;
  eventTypes: EventTypeWhereUniqueInput;
};
