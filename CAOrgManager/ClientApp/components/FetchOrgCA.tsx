import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { Link, NavLink } from 'react-router-dom';
import { Select } from './Select';

interface FetchOrgPaDataState {
    empList: OrgPaData[];
    loading: boolean;
    input: boolean;
    uniqueNameList: OrgPaData[];
}

export class FetchOrgCA extends React.Component<RouteComponentProps<{}>, FetchOrgPaDataState> {
    constructor() {
        super();
        this.state = { empList: [], loading: true, input: false, uniqueNameList: [] };

        fetch('api/OrgPa/FetchAll')
            .then(response => {
                return response.body ? response.json() as Promise<OrgPaData[]> : [];
            })
            .then(data => {
                this.setState({ empList: data, loading: false });
                this.getCaGroup();
            });
    }
    public render() {
        
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderOrgCaTable(this.state.empList);
        return <div>
            <h1>Project Accounting Responsibility Manager</h1>
            <p>This component allows users to update PA assigned orgs.</p>
            {contents}
        </div>;
    }

    private getCaGroup() {

        let uniqueNames = this.state.empList.map(a => a)
            .sort((a, b) => (a.orgPaUid > b.orgPaUid) ? 1 : ((b.orgPaUid > a.orgPaUid) ? -1 : 0))
            .filter((emp, index, arr) => arr[index - 1] && !(arr[index - 1].orgPaUid === emp.orgPaUid));

        this.setState({uniqueNameList: uniqueNames});
    }

    private changeUid(o: OrgPaData) {
        this.state

    }

    // Returns the HTML table to the render() method.  
    private renderOrgCaTable(empList: OrgPaData[]) {

        return <table className='table table-condensed table-responsive table-hover'>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Billing Org</th>
                    <th>Practice Area</th>
                    <th>Office</th>
                    <th>Project Accountant</th>
                </tr>
            </thead>
            <tbody>
                {empList.map(oc =>
                    <tr key={oc.id}>
                        <td>{oc.id}</td>
                        <td>{oc.orgCode}</td>
                        <td>{oc.practiceArea}</td>
                        <td>{oc.office}</td>
                        <td>
                            <Select
                                OrgPaData={oc}
                                users={this.state.uniqueNameList}
                                changeUid={this.changeUid}>
                            </Select>
                        </td>
                    </tr>
                )}
            </tbody>
        </table>;
    }
}

export class OrgPaData {
    id: number = 0;
    name: string = "";
    orgPaUid: string = "";
    orgCode: string = "";
    practiceArea: string = "";
    office: string = "";
}

export class ca {
    id: string = "";
    name: string = "";
}
