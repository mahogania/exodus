import * as React from "react";
import {
  Create,
  SimpleForm,
  CreateProps,
  ReferenceInput,
  SelectInput,
} from "react-admin";
import { PropertyTypeTitle } from "../propertyType/PropertyTypeTitle";
import { EventTypeTitle } from "../eventType/EventTypeTitle";

export const ObjectTypeCreate = (props: CreateProps): React.ReactElement => {
  return (
    <Create {...props}>
      <SimpleForm>
        <ReferenceInput
          source="PropertyTypes.id"
          reference="PropertyType"
          label="Property Types"
        >
          <SelectInput optionText={PropertyTypeTitle} />
        </ReferenceInput>
        <ReferenceInput
          source="eventTypes.id"
          reference="EventType"
          label="Event Types"
        >
          <SelectInput optionText={EventTypeTitle} />
        </ReferenceInput>
      </SimpleForm>
    </Create>
  );
};
