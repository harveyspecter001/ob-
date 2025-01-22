using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x0200091B RID: 2331
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterListRequest : IMessage<CharacterListRequest>, IMessage, IEquatable<CharacterListRequest>, IDeepCloneable<CharacterListRequest>, IBufferMessage
	{
		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x0600711C RID: 28956 RVA: 0x0023C1D4 File Offset: 0x0023A3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x0600711D RID: 28957 RVA: 0x0023C1E4 File Offset: 0x0023A3E4
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

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x0600711E RID: 28958 RVA: 0x0023C1F4 File Offset: 0x0023A3F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x0023C204 File Offset: 0x0023A404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListRequest()
		{
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x0023C214 File Offset: 0x0023A414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListRequest(CharacterListRequest other)
		{
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x0023C224 File Offset: 0x0023A424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterListRequest Clone()
		{
			return null;
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x0023C234 File Offset: 0x0023A434
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x0023C244 File Offset: 0x0023A444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterListRequest other)
		{
			return true;
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x0023C254 File Offset: 0x0023A454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x0023C264 File Offset: 0x0023A464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x0023C274 File Offset: 0x0023A474
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x0023C284 File Offset: 0x0023A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x0023C294 File Offset: 0x0023A494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x0023C2A4 File Offset: 0x0023A4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterListRequest other)
		{
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x0023C2B4 File Offset: 0x0023A4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600712B RID: 28971 RVA: 0x0023C2C4 File Offset: 0x0023A4C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600712C RID: 28972 RVA: 0x0023C2D4 File Offset: 0x0023A4D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterListRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_A0;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ca3643a142274c248309f603d25ccd10 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_88;
					}
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 == 0)
					{
						num2 = 1;
					}
				}
				IL_88:
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
				num = 3;
				continue;
				IL_A0:
				CharacterListRequest._parser = new MessageParser<CharacterListRequest>(() => null);
				num = 2;
			}
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x0023C3A8 File Offset: 0x0023A5A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LgHyfTJeIuqypEjeNyRw()
		{
			return true;
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x0023C3B0 File Offset: 0x0023A5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterListRequest VVMlm1JekqRc7vVcSAk7()
		{
			return null;
		}

		// Token: 0x040027A0 RID: 10144
		private static readonly MessageParser<CharacterListRequest> _parser;

		// Token: 0x040027A1 RID: 10145
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027A2 RID: 10146
		internal static CharacterListRequest JPfWxXJeKl4H00syNpgF;
	}
}
