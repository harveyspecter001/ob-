using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000921 RID: 2337
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterNameSuggestionRequest : IMessage<CharacterNameSuggestionRequest>, IMessage, IEquatable<CharacterNameSuggestionRequest>, IDeepCloneable<CharacterNameSuggestionRequest>, IBufferMessage
	{
		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x0023C7C8 File Offset: 0x0023A9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterNameSuggestionRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06007169 RID: 29033 RVA: 0x0023C7D8 File Offset: 0x0023A9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x0023C7E8 File Offset: 0x0023A9E8
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

		// Token: 0x0600716B RID: 29035 RVA: 0x0023C7F8 File Offset: 0x0023A9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameSuggestionRequest()
		{
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x0023C808 File Offset: 0x0023AA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameSuggestionRequest(CharacterNameSuggestionRequest other)
		{
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x0023C818 File Offset: 0x0023AA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterNameSuggestionRequest Clone()
		{
			return null;
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x0023C828 File Offset: 0x0023AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x0023C838 File Offset: 0x0023AA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterNameSuggestionRequest other)
		{
			return true;
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x0023C848 File Offset: 0x0023AA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x0023C858 File Offset: 0x0023AA58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x0023C868 File Offset: 0x0023AA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x0023C878 File Offset: 0x0023AA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x0023C888 File Offset: 0x0023AA88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x0023C898 File Offset: 0x0023AA98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterNameSuggestionRequest other)
		{
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x0023C8A8 File Offset: 0x0023AAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x0023C8B8 File Offset: 0x0023AAB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x0023C8C8 File Offset: 0x0023AAC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterNameSuggestionRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_29e9ac3faf0b4be1a7385fa6620e7935 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					CharacterNameSuggestionRequest._parser = new MessageParser<CharacterNameSuggestionRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1c578dbef51f4bd9998711c064153a04 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x0023C9AC File Offset: 0x0023ABAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yYdPNaJe5sk1It2mjpxf()
		{
			return true;
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x0023C9B4 File Offset: 0x0023ABB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterNameSuggestionRequest Q8sL7MJeyuo6xeX1VRvr()
		{
			return null;
		}

		// Token: 0x040027B3 RID: 10163
		private static readonly MessageParser<CharacterNameSuggestionRequest> _parser;

		// Token: 0x040027B4 RID: 10164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027B5 RID: 10165
		private static CharacterNameSuggestionRequest GWFjYfJeaFx7u2dQu0hn;
	}
}
