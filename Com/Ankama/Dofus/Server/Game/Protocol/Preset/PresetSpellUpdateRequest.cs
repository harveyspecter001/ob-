using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset
{
	// Token: 0x0200023B RID: 571
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PresetSpellUpdateRequest : IMessage<PresetSpellUpdateRequest>, IMessage, IEquatable<PresetSpellUpdateRequest>, IDeepCloneable<PresetSpellUpdateRequest>, IBufferMessage
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x001B0908 File Offset: 0x001AEB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PresetSpellUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x001B0918 File Offset: 0x001AEB18
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

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x001B0928 File Offset: 0x001AEB28
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

		// Token: 0x06001AAA RID: 6826 RVA: 0x001B0938 File Offset: 0x001AEB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSpellUpdateRequest()
		{
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x001B0948 File Offset: 0x001AEB48
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSpellUpdateRequest(PresetSpellUpdateRequest other)
		{
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x001B0958 File Offset: 0x001AEB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetSpellUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x001B0968 File Offset: 0x001AEB68
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x001B0978 File Offset: 0x001AEB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PresetUuid
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x001B0988 File Offset: 0x001AEB88
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x001B099C File Offset: 0x001AEB9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public PresetSpellUpdateRequest.Types.Target Target
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PresetSpellUpdateRequest.Types.Target)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x001B09AC File Offset: 0x001AEBAC
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x001B09BC File Offset: 0x001AEBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellPreset SpellPreset
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

		// Token: 0x06001AB3 RID: 6835 RVA: 0x001B09CC File Offset: 0x001AEBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x001B09DC File Offset: 0x001AEBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PresetSpellUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x001B09EC File Offset: 0x001AEBEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x001B09FC File Offset: 0x001AEBFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x001B0A0C File Offset: 0x001AEC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x001B0A1C File Offset: 0x001AEC1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x001B0A2C File Offset: 0x001AEC2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x001B0A3C File Offset: 0x001AEC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PresetSpellUpdateRequest other)
		{
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x001B0A4C File Offset: 0x001AEC4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x001B0A5C File Offset: 0x001AEC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x001B0A6C File Offset: 0x001AEC6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PresetSpellUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ec51c76f8d943f08859e3c2be1f0d41 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
					PresetSpellUpdateRequest._parser = new MessageParser<PresetSpellUpdateRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_92f0fecb2683415180122e9645e6a542 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x001B0B50 File Offset: 0x001AED50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KVd6fqO5fqyRTXNh7Rb3()
		{
			return true;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x001B0B58 File Offset: 0x001AED58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PresetSpellUpdateRequest LusniSO5nm8wjYXxfBqd()
		{
			return null;
		}

		// Token: 0x0400097E RID: 2430
		private static readonly MessageParser<PresetSpellUpdateRequest> _parser;

		// Token: 0x0400097F RID: 2431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000980 RID: 2432
		public const int PresetUuidFieldNumber = 1;

		// Token: 0x04000981 RID: 2433
		private string presetUuid_;

		// Token: 0x04000982 RID: 2434
		public const int TargetFieldNumber = 2;

		// Token: 0x04000983 RID: 2435
		private PresetSpellUpdateRequest.Types.Target target_;

		// Token: 0x04000984 RID: 2436
		public const int SpellPresetFieldNumber = 3;

		// Token: 0x04000985 RID: 2437
		private SpellPreset spellPreset_;

		// Token: 0x04000986 RID: 2438
		private static PresetSpellUpdateRequest aLuYTTOazSDJmnpFQn1X;

		// Token: 0x0200023C RID: 572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x06001AC0 RID: 6848 RVA: 0x002B1E1C File Offset: 0x002B001C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x0200023D RID: 573
			public enum Target
			{
				// Token: 0x04000988 RID: 2440
				[OriginalName("CHARACTER")]
				Character,
				// Token: 0x04000989 RID: 2441
				[OriginalName("FORGETTABLE_BASE")]
				ForgettableBase,
				// Token: 0x0400098A RID: 2442
				[OriginalName("FORGETTABLE_SPELL")]
				ForgettableSpell
			}
		}
	}
}
