using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x02000211 RID: 529
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ForgettableSpellPresetCreateRequest : IMessage<ForgettableSpellPresetCreateRequest>, IMessage, IEquatable<ForgettableSpellPresetCreateRequest>, IDeepCloneable<ForgettableSpellPresetCreateRequest>, IBufferMessage
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x001AE5D4 File Offset: 0x001AC7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ForgettableSpellPresetCreateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x001AE5E4 File Offset: 0x001AC7E4
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x001AE5F4 File Offset: 0x001AC7F4
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

		// Token: 0x060018AF RID: 6319 RVA: 0x001AE604 File Offset: 0x001AC804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetCreateRequest()
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x001AE614 File Offset: 0x001AC814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetCreateRequest(ForgettableSpellPresetCreateRequest other)
		{
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x001AE624 File Offset: 0x001AC824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ForgettableSpellPresetCreateRequest Clone()
		{
			return null;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x001AE634 File Offset: 0x001AC834
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x001AE644 File Offset: 0x001AC844
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Name
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x001AE654 File Offset: 0x001AC854
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x001AE664 File Offset: 0x001AC864
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SymbolId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x001AE674 File Offset: 0x001AC874
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x001AE684 File Offset: 0x001AC884
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetOrigin Origin
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

		// Token: 0x060018B8 RID: 6328 RVA: 0x001AE694 File Offset: 0x001AC894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x001AE6A4 File Offset: 0x001AC8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ForgettableSpellPresetCreateRequest other)
		{
			return true;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x001AE6B4 File Offset: 0x001AC8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x001AE6C4 File Offset: 0x001AC8C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x001AE6D4 File Offset: 0x001AC8D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x001AE6E4 File Offset: 0x001AC8E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x001AE6F4 File Offset: 0x001AC8F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x001AE704 File Offset: 0x001AC904
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ForgettableSpellPresetCreateRequest other)
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x001AE714 File Offset: 0x001AC914
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x001AE724 File Offset: 0x001AC924
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x001AE734 File Offset: 0x001AC934
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ForgettableSpellPresetCreateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_55f229ec1230462892d96f1674049f2c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 4:
					ForgettableSpellPresetCreateRequest._parser = new MessageParser<ForgettableSpellPresetCreateRequest>(() => null);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x001AE818 File Offset: 0x001ACA18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool I9F6f3Oa9yYgwaVmctHQ()
		{
			return true;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x001AE820 File Offset: 0x001ACA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ForgettableSpellPresetCreateRequest PxtqBlOa21U9hQkdP6Qb()
		{
			return null;
		}

		// Token: 0x040008CB RID: 2251
		private static readonly MessageParser<ForgettableSpellPresetCreateRequest> _parser;

		// Token: 0x040008CC RID: 2252
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008CD RID: 2253
		public const int NameFieldNumber = 1;

		// Token: 0x040008CE RID: 2254
		private string name_;

		// Token: 0x040008CF RID: 2255
		public const int SymbolIdFieldNumber = 2;

		// Token: 0x040008D0 RID: 2256
		private int symbolId_;

		// Token: 0x040008D1 RID: 2257
		public const int OriginFieldNumber = 3;

		// Token: 0x040008D2 RID: 2258
		private PresetOrigin origin_;

		// Token: 0x040008D3 RID: 2259
		private static ForgettableSpellPresetCreateRequest iDliPEOad3am7cwOQqKr;
	}
}
