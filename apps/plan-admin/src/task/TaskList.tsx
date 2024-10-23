import * as React from "react";
import {
  List,
  Datagrid,
  ListProps,
  ReferenceField,
  TextField,
  DateField,
} from "react-admin";
import Pagination from "../Components/Pagination";
import { ACTION_TITLE_FIELD } from "../action/ActionTitle";
import { STEP_TITLE_FIELD } from "../step/StepTitle";

export const TaskList = (props: ListProps): React.ReactElement => {
  return (
    <List {...props} title={"Tasks"} perPage={50} pagination={<Pagination />}>
      <Datagrid rowClick="show" bulkActionButtons={false}>
        <ReferenceField label="Action" source="action.id" reference="Action">
          <TextField source={ACTION_TITLE_FIELD} />
        </ReferenceField>
        <TextField label="Context" source="context" />
        <DateField source="createdAt" label="Created At" />
        <TextField label="ID" source="id" />
        <TextField label="Kind" source="kind" />
        <ReferenceField label="Step" source="step.id" reference="Step">
          <TextField source={STEP_TITLE_FIELD} />
        </ReferenceField>
        <DateField source="updatedAt" label="Updated At" />{" "}
      </Datagrid>
    </List>
  );
};
