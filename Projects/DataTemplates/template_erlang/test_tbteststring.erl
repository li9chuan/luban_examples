
%% test.TbTestString

get(1) -> #{id => 1,s1 => "asfas",cs1 => #{id => 1,s2 => "asf",s3 => "aaa"},cs2 => #{id => 1,s2 => "asf",s3 => "aaa"}}.

get(2) -> #{id => 2,s1 => "adsf\"",cs1 => #{id => 2,s2 => "",s3 => "bbb"},cs2 => #{id => 2,s2 => "",s3 => "bbb"}}.

get(3) -> #{id => 3,s1 => "升级到10级\"\"",cs1 => #{id => 3,s2 => "asdfas",s3 => ""},cs2 => #{id => 3,s2 => "asdfas",s3 => ""}}.

get(4) -> #{id => 4,s1 => "asdfa",cs1 => #{id => 4,s2 => "",s3 => ""},cs2 => #{id => 4,s2 => "",s3 => ""}}.
