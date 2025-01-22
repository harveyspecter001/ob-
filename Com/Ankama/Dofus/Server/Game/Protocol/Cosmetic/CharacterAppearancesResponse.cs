using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C61 RID: 3169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterAppearancesResponse : IMessage<CharacterAppearancesResponse>, IMessage, IEquatable<CharacterAppearancesResponse>, IDeepCloneable<CharacterAppearancesResponse>, IBufferMessage
	{
		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x0600982F RID: 38959 RVA: 0x0027A9F8 File Offset: 0x00278BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterAppearancesResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06009830 RID: 38960 RVA: 0x0027AA08 File Offset: 0x00278C08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06009831 RID: 38961 RVA: 0x0027AA18 File Offset: 0x00278C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06009832 RID: 38962 RVA: 0x0027AA28 File Offset: 0x00278C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearancesResponse()
		{
		}

		// Token: 0x06009833 RID: 38963 RVA: 0x0027AA38 File Offset: 0x00278C38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearancesResponse(CharacterAppearancesResponse other)
		{
		}

		// Token: 0x06009834 RID: 38964 RVA: 0x0027AA48 File Offset: 0x00278C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterAppearancesResponse Clone()
		{
			return null;
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06009835 RID: 38965 RVA: 0x0027AA58 File Offset: 0x00278C58
		// (set) Token: 0x06009836 RID: 38966 RVA: 0x0027AA68 File Offset: 0x00278C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterFaces CharacterFaces
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06009837 RID: 38967 RVA: 0x0027AA78 File Offset: 0x00278C78
		// (set) Token: 0x06009838 RID: 38968 RVA: 0x0027AA88 File Offset: 0x00278C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterColors CharacterColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x0027AA98 File Offset: 0x00278C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x0027AAA8 File Offset: 0x00278CA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterAppearancesResponse other)
		{
			return true;
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x0027AAB8 File Offset: 0x00278CB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x0027AAC8 File Offset: 0x00278CC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600983D RID: 38973 RVA: 0x0027AAD8 File Offset: 0x00278CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600983E RID: 38974 RVA: 0x0027AAE8 File Offset: 0x00278CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x0027AAF8 File Offset: 0x00278CF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x0027AB08 File Offset: 0x00278D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterAppearancesResponse other)
		{
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x0027AB18 File Offset: 0x00278D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x0027AB28 File Offset: 0x00278D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009843 RID: 38979 RVA: 0x0027AB38 File Offset: 0x00278D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterAppearancesResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					CharacterAppearancesResponse._parser = new MessageParser<CharacterAppearancesResponse>(() => null);
					num2 = 4;
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06009844 RID: 38980 RVA: 0x0027AC04 File Offset: 0x00278E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jfXEsWJNUd0CbaC3Wffd()
		{
			return true;
		}

		// Token: 0x06009845 RID: 38981 RVA: 0x0027AC0C File Offset: 0x00278E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterAppearancesResponse lJChuHJNvQ5vti0Ga2Rn()
		{
			return null;
		}

		// Token: 0x0400387A RID: 14458
		private static readonly MessageParser<CharacterAppearancesResponse> _parser;

		// Token: 0x0400387B RID: 14459
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400387C RID: 14460
		public const int CharacterFacesFieldNumber = 1;

		// Token: 0x0400387D RID: 14461
		private CharacterFaces characterFaces_;

		// Token: 0x0400387E RID: 14462
		public const int CharacterColorsFieldNumber = 2;

		// Token: 0x0400387F RID: 14463
		private CharacterColors characterColors_;

		// Token: 0x04003880 RID: 14464
		internal static CharacterAppearancesResponse tQmWUGJNcGpo0o7ATqJk;
	}
}
