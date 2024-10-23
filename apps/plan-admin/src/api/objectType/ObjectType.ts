import { ObjectType } from "@nestjs/graphql";
import { PropertyType } from "../propertyType/PropertyType";
import { EventType } from "../eventType/EventType";

export type ObjectType = {
  PropertyTypes?: PropertyType;
  createdAt: Date;
  eventTypes?: EventType;
  id: string;
  updatedAt: Date;
};
