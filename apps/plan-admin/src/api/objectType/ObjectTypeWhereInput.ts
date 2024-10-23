import { PropertyTypeWhereUniqueInput } from "../propertyType/PropertyTypeWhereUniqueInput";
import { EventTypeWhereUniqueInput } from "../eventType/EventTypeWhereUniqueInput";
import { StringFilter } from "../../util/StringFilter";

export type ObjectTypeWhereInput = {
  PropertyTypes?: PropertyTypeWhereUniqueInput;
  eventTypes?: EventTypeWhereUniqueInput;
  id?: StringFilter;
};
